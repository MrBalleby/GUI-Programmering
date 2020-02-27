const express = require("express");
const reservations = express.Router();
const cors = require("cors");

const Reservation = require("../models/Reservation");
reservations.use(cors());

reservations.get('/today', (req, res) => {
  Reservation.today.findAll()
  .then(reservations => {
    res.json(reservations);
  })
  .catch(err => {
    res.send('error: ' + err);
  });
});

reservations.get('/info/:id', (req, res) => {
  Reservation.info.findOne({
    where: {
      id: req.params.id
    }
  })
  .then(reservation => {
    res.json(reservation);
  })
  .catch(err => {
    res.send('error: ' + err);
  });
});

module.exports = reservations;