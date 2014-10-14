var initiatives = [
    'Software Academy',
    'Algo Academy',
    'School Academy',
    'Kids Academy'
];

module.exports = {
    getAllInitiatives: function () {
        return initiatives;
    },
    getInitiativeByIndex: function (index) {
        return initiatives[index];
    }
};