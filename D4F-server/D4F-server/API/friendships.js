var db = require('./DBconnect.js');


module.exports = {
	addFriend: function (user1,user2,callback) {
		db.nonQuery("INSERT INTO friendships(user1,user2) VALUES(" + user1 + ", " + user2 + ")", function (success) { 
			if (typeof callback === "function") {
				callback(success);
			}
		});
	},

	deleteFriend: function (requestid, callback) {
		db.nonQuery("DELETE FROM friend_requests WHERE requestid="+requestid, function (success) {
			if (typeof callback === "function") {
				callback(success);
			}
		});
	},

	

	loadRequests: function (userid,callback) {
		db.query("SELECT userid,name,surname,nickname FROM friend_requests INNER JOIN users ON friend_requests.sender=users.userid WHERE receiver=" + userid, function (results) {
			if (typeof callback === "function") {
				callback(results);
			}
		});
	}
};
