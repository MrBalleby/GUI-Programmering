const Sequelize = require("sequelize");
const db = require("../database/db.js");

var today = db.sequelize.define(
  'today_reservations',
  {
    table_id: {
      type: Sequelize.INTEGER,
      primaryKey: true
    },
    table: {
      type: Sequelize.STRING
    },
    number_of_seats: {
      type: Sequelize.INTEGER
    },
    res_in_16: {
      type: Sequelize.INTEGER
    },
    res_in_17: {
      type: Sequelize.INTEGER
    },
    res_in_18: {
      type: Sequelize.INTEGER
    },
    res_in_19: {
      type: Sequelize.INTEGER
    },
    res_in_20: {
      type: Sequelize.INTEGER
    },
    res_in_21: {
      type: Sequelize.INTEGER
    },
    res_in_22: {
      type: Sequelize.INTEGER
    },
    res_in_23: {
      type: Sequelize.INTEGER
    }
  },
  {
    timestamps: false
  }
);

var info = db.sequelize.define(
  'info_reservations',
  {
    id: {
      type: Sequelize.INTEGER,
      primaryKey: true
    },
    employee: {
      type: Sequelize.STRING
    },
    table: {
      type: Sequelize.STRING
    },
    start_date: {
      type: Sequelize.DATE
    },
    end_date: {
      type: Sequelize.DATE
    }
  },
  {
    timestamps: false
  }
);

module.exports = {
  today,
  info
};