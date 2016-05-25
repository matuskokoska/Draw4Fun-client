var db = require('./DBconnect.js');
var hash = require('password-hash');


module.exports = {
	login: function (nickname, password, callback){
        db.query("SELECT id, password FROM users WHERE nickname LIKE '" + nickname + "'", function(result) {
  							if(result[0].password==password){
									var success=true;
								}
								else{
									var success=false;
								}
								if (typeof callback === "function") {
				                    callback(success);
				        }
        });
	}
};
