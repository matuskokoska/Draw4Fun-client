var db = require('./DBconnect.js');

module.exports = {
    getRandomWord: function(cat,callback){
      db.query("SELECT * FROM words WHERE category="+cat,function(result){
        var len=result.length;
        if(len!=0 && typeof callback === "function"){
          var rand=Math.floor(Math.random() * (len));
          console.log(rand);
          console.log(result[rand]);
          callback(result[rand]);
        }
      })

    }
}
