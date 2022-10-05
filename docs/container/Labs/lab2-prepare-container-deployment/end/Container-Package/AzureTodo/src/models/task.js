const mongoose = require('mongoose');

const taskSchema = new mongoose.Schema({
  taskName: {
    type: String,
    trim: true,
  },
  createDate: Date,
  completedDate: Date,
  completed: Boolean
});

module.exports = mongoose.model('Task', taskSchema);