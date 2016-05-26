var db = require('./DBconnect.js');


module.exports = {
	login: function (nickname, password, callback){
        db.query("SELECT id, password FROM users WHERE nickname LIKE '" + nickname + "'", function(result) {
						if(result.length!=0){
							if(result[0].password==password){
								var success=true;
								var id=result[0].id;
							}
							else{
								var success=false;
								var id=0;
							}
							if (typeof callback === "function") {
													callback(success,id);
							}
						}
						else{
							if (typeof callback === "function") {
													callback(false,0);
							}
						}

        });
	}
};
