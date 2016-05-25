var express = require('express');
var router = express.Router();
var bodyParser = require("body-parser");
//var regex = require(appRoot + '/API/regex.js');

router.post('/', function (req, res) {
	var password = req.body.password;
    var nickname = req.body.nickname;
        var reg = require(appRoot + "/API/register");
        reg.register(nickname, password, function (success) {
            console.log(success);
            res.json(success);
        });
});



module.exports = router;
