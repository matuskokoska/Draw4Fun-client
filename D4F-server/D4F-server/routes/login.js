var express = require('express');
var router = express.Router();
var bodyParser = require("body-parser");


router.post('/', function (req, res) {
    var nickname = req.body.nickname;
    var password = req.body.password;
    var login = require(appRoot + "/API/login");
	login.login(nickname, password, function (success,id) {
		console.log(success);
		res.json({
      "success":success,
      "id": id
    });
	});
});



module.exports = router;
