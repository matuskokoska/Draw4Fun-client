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
    db.query("SELECT sum((0.5+drawings.combo*0.5)*wordcategories.points) AS score FROM `drawings`"+
    "INNER JOIN words ON words.id=drawings.wordid"+
    "INNER JOIN wordcategories ON words.category=wordcategories.id"+
    "WHERE state=2 AND (painter="+userid+" OR reciever="+userid+")",function(result){
      if (typeof callback === "function") {
				callback(result[0].score);
			}
    });
  }
};
