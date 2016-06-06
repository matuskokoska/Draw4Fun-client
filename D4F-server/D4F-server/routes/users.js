var express = require('express');
var router = express.Router();
var bodyParser = require("body-parser");
var users = require(appRoot + "/API/users");
var friends = require(appRoot + "/API/friendships");

router.post('/load', function (req, res) {
    var userid = req.body.userid;
    users.load(userid, function (user) {
        res.json(user);
    });
});

router.post('/search', function (req, res) {
    var name = req.body.name;
    users.search(name, function (results) {
        res.json(results);
    });
});

router.post('/getfriends', function (req, res) {
    var userid = req.body.userid;
    friends.loadfriends(userid, function (results) {
        res.json(results);
    });
});

router.post('/addfriend', function (req, res) {
    var userid = req.body.userid;
    var friendid = req.body.friendid;
    friends.addfriend(userid, function (success) {
        res.json(success);
    });
});

router.post('/removefriend', function (req, res) {
    var userid = req.body.userid;
    var friendid = req.body.friendid;
    friends.deleteFriend(userid, function (success) {
        res.json(success);
    });
});

router.post('/score', function(req,res){
    var userid=req.body.userid;
    users.getScore(userid,function(score){
      res.json(score);
    });
});

module.exports = router;
