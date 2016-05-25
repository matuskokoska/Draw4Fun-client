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
	}
};
