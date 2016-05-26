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
    }

}
