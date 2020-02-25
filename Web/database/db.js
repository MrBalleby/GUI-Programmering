const Sequelize = require("sequelize");
const db = {}
const sequelize = new Sequelize("restaurant", "db_user", "Password1", {
  host: "192.168.132.33",
  dialect: "mysql",
  pool: {
    max: 5,
    min: 0,
    acquire: 30000,
    idle: 10000
  }
});

db.sequelize = sequelize;
db.Sequelize = Sequelize;

module.exports = db;