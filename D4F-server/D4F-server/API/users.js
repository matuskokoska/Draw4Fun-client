var db = require('./DBconnect.js');

module.exports = {
    load: function (userid,callback) {
        db.query("SELECT id,nickname FROM users WHERE userid="+userid+"",
        function (result) {
            if (typeof callback === "function") {
                callback(result[0]);
            }
        });
    },

	searchUser: function (name, callback) {
		db.Query("SELECT id,nickname FROM users WHERE nickname LIKE '%" + name + "%'",
        function (results) {
			if (typeof callback === "function") {
				callback(results);
			}
		});
	},

  getScore: function(userid, callback){
    db.query("SELECT sum((0.5+drawings.combo*0.5)*wordcategories.points) AS score FROM `drawings` "+
    "INNER JOIN words ON words.id=drawings.wordid "+
    "INNER JOIN wordcategories ON words.category=wordcategories.id "+
    "WHERE state=2 AND (painter="+userid+" OR reciever="+userid+")",function(result){
      if (typeof callback === "function") {
        if(result[0].score!=null){
          callback(result[0].score);
        }
        else{
          callback(0);
        }

			}
    });
  },

  getLeaderboard: function(callback){
    db.query("SELECT id, nickname, (coalesce(score1, 0) + coalesce(score2, 0))as score FROM users "+
              "LEFT JOIN (SELECT painter, sum((0.5+drawings.combo*0.5)*wordcategories.points) AS score1 FROM `drawings` INNER JOIN words ON words.id=drawings.wordid INNER JOIN wordcategories ON words.category=wordcategories.id WHERE state=2 GROUP BY painter) painterscore ON painterscore.painter=users.id "+
              "LEFT JOIN (SELECT reciever, sum((0.5+drawings.combo*0.5)*wordcategories.points) AS score2 FROM `drawings` INNER JOIN words ON words.id=drawings.wordid INNER JOIN wordcategories ON words.category=wordcategories.id WHERE state=2 GROUP BY reciever) receiverscore ON receiverscore.reciever=users.id "+
              "ORDER BY score DESC limit 10",function(results){
                if (typeof callback === "function") {
          				callback(results);
          			}
              });
  }
};
