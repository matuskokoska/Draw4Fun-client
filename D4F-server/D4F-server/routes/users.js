var express = require('express');
var router = express.Router();
var bodyParser = require("body-parser");
var users = require(appRoot + "/API/users");

router.post('/load', function (req, res) {
    var userid = req.body.userid;
    users.load(userid, function (user) {
        res.json(user);
    });
});

router.post('/search', function (req, res) {
    var name = req.body.name;
    users.search(userid, function (results) {
        res.json(results);
    });
});

module.exports = router;
