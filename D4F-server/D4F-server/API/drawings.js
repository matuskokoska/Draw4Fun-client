var db = require('./DBconnect.js');

function getCombo(painter, receiver, callback){
  db.query("SELECT count(*) AS count FROM drawings WHERE "
          +"(painter LIKE '"+painter+"' AND reciever LIKE '"+receiver+"') OR (painter LIKE '"+receiver+"' AND reciever LIKE '"+painter+"')",
          function(result){

            var combo=(result[0].count)+1;
            if (typeof callback === "function") {
                        callback(combo);
            }
          });
}

module.exports = {
    new: function(wordid,painter, receiver, stream, callback){
        getCombo(painter, receiver,function(combo){
            db.nonQuery("INSERT INTO drawings(wordid,painter,reciever,state,combo) VALUES ("+wordid+","+painter+","+receiver+",0,"+combo+")",
            function(success){
              if(success){
                db.nonQuery("INSERT INTO streams(streambinary) VALUES ('"+stream+"')",function(success2){
                  if (typeof callback === "function") {
    													callback(success2);
    							}
                });
              }
              else{
                if (typeof callback === "function") {
                            callback(false);
                }
              }
            });
        });
    },
    setState: function(value, id, callback){
      db.nonQuery("UPDATE drawings SET state="+value+" WHERE id="+id,function(success){
        if (typeof callback === "function") {
              callback(success);
        }
      })
    },
    get: function(receiver, callback){
      console.log("SELECT drawings.id AS id, word, users.id AS painterid, nickname, wordcategories.name AS cat, datepainted FROM drawings "+
        "INNER JOIN users ON drawings.painter=users.id INNER JOIN words ON words.id=drawings.wordid INNER JOIN wordcategories ON wordcategories.id=words.category"+
        "WHERE reciever="+receiver+" AND state=0");
      db.query("SELECT drawings.id AS id, word, users.id AS painterid, nickname, wordcategories.name AS cat, datepainted FROM drawings "+
      " INNER JOIN users ON drawings.painter=users.id INNER JOIN words ON words.id=drawings.wordid INNER JOIN wordcategories ON wordcategories.id=words.category"+
      " WHERE reciever="+receiver+" AND state=0", function(results){
        if (typeof callback === "function") {
              callback(results);
        }
      });
    },
    getStream: function(id, callback){
      db.query("SELECT streambinary FROM streams WHERE id="+id, function(results){
        if (typeof callback === "function") {
              callback(results);
        }
      });
    }

}
