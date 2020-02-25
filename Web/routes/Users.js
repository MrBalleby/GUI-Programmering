const express = require("express");
const users = express.Router();
const cors = require("cors");
const jwt = require("jsonwebtoken");
const bcrypt = require("bcrypt");

const User = require("../models/User");
users.use(cors());

process.env.SECRET_KEY = 'secret';

// Register
users.post('/register', (req, res) => {
  const today = Date();
  const userData = {
    first_name: req.body.first_name,
    last_name: req.body.last_name,
    email: req.body.email,
    password: req.body.password,
    created: today
  }

  User.findOne({
    where: {
      email: req.body.email
    }
  }).then(user => {
    if (!user) {
      const hash = bcrypt.hashSync(userData.password, 10);
      userData.password = hash;
      User.create(userData)
        .then(user => {
          let token = jwt.sign(user.dataValues, process.env.SECRET_KEY, {
            expiresIn: 1440
          })
          res.json({ token: token })
        })
        .catch(err => {
          res.send('error: ' + error)
        })
    } else {
      res.json({ error: 'User already exists' })
    }
  })
  .catch(err => {
    res.send('error: ' + err)
  })
});

module.exports = users;