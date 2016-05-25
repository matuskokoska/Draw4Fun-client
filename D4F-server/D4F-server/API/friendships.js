var db = require('./DBconnect.js');


module.exports = {
	addFriend: function (user1,user2,callback) {
		db.nonQuery("INSERT INTO friendships(user1,user2) VALUES(" + user1 + ", " + user2 + ")", function (success) {
			if (typeof callback === "function") {
				callback(success);
			}
		});
	},

	deleteFriend: function (user1, user2, callback) {
		db.nonQuery("DELETE FROM friendships WHERE user1="+user1+" AND user2="+user2, function (success) {
			if (typeof callback === "function") {
				callback(success);
			}
		});
	},


	loadFriends: function (userid,callback) {
		db.query("SELECT id,nickname FROM friendships INNER JOIN users ON friendships.user2=users.id WHERE user1=" + userid, function (results) {
			if (typeof callback === "function") {
				callback(results);
			}
		});
	}
};
