var db = require('./DBconnect.js');

function getCombo(painter, receiver, callback){
  console.log("SELECT coalesce(combo, 0) AS cmb FROM drawings WHERE "
          +"(painter LIKE '"+painter+"' AND reciever LIKE '"+receiver+"') OR (painter LIKE '"+receiver+"' AND reciever LIKE '"+painter+ "') "
          +"ORDER BY id DESC LIMIT 1");
  db.query("SELECT coalesce(combo, 0) AS cmb FROM drawings WHERE "
          +"(painter LIKE '"+painter+"' AND reciever LIKE '"+receiver+"') OR (painter LIKE '"+receiver+"' AND reciever LIKE '"+painter+ "') "
          +"ORDER BY id DESC LIMIT 1",
          function(result){
            console.log(result);
            if(result.length==0){
              var combo=1;
            }
            else{
              var combo=(result[0].cmb)+1;
            }
            if (typeof callback === "function") {
                  callback(combo);
            }
          });
}

function getReceiver(painter, receiver, callback){
  if(receiver==0){
    db.query("SELECT id FROM users "+
             "WHERE id NOT IN(SELECT id FROM friendships INNER JOIN users ON friendships.user2=users.id WHERE user1=5) "+
             "ORDER BY Rand() LIMIT 1", function(results){
               if (typeof callback === "function") {
                           callback(results[0].id);
               }
             });
  }
  else{
      if (typeof callback === "function") {
              callback(receiver);
      }
  }
}

module.exports = {
    new: function(wordid,painter, receiver, stream, callback){
        getReceiver(painter, receiver, function(finalReciever){
            getCombo(painter, finalReciever,function(combo){
              db.nonQuery("INSERT INTO drawings(wordid,painter,reciever,state,combo) VALUES ("+wordid+","+painter+","+finalReciever+",0,"+combo+")",
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
        });
    },
    setState: function(value, id, callback){
      db.nonQuery("UPDATE drawings SET state="+value+",combo=0 WHERE id="+id,function(success){
        if (typeof callback === "function") {
              callback(success);
        }
      })
    },
    get: function(receiver, callback){
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
