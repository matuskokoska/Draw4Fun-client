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
    var userid = req.body.userid;
    users.search(name, userid, function (results) {
        res.json(results);
    });
});

router.post('/getfriends', function (req, res) {
    var userid = req.body.userid;
    friends.loadFriends(userid, function (results) {
        res.json(results);
    });
});

router.post('/addfriend', function (req, res) {
    var userid = req.body.userid;
    var friendid = req.body.friendid;
    friends.addFriend(userid, friendid, function (success) {
        res.json(success);
    });
});

router.post('/removefriend', function (req, res) {
    var userid = req.body.userid;
    var friendid = req.body.friendid;
    friends.deleteFriend(userid, friendid, function (success) {
        res.json(success);
    });
});

router.post('/score', function(req,res){
    var userid=req.body.userid;
    users.getScore(userid,function(score){
      res.json(score);
    });
});

router.get('/leaderboard',function(req,res){
  users.getLeaderboard(function(results){
    res.json(results);
  });
});

module.exports = router;
