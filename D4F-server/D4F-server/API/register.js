var db = require('./DBconnect.js');

module.exports = {
	register: function (nickname password, callback) {
        db.nonQuery("INSERT INTO users(nickname,password) VALUES ('" + nickname + "','" + password + "')",
        function (success){
			if (typeof callback === "function") {
				callback(success);
			}
        });
    }
};
