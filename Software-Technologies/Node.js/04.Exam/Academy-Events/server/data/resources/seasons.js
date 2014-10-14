var seasons = [
    'Started 2010',
    'Started 2011',
    'Started 2012',
    'Started 2013',
    'Started 2014'
];

module.exports = {
    getAllSeasons: function () {
        return seasons;
    },
    getSeasonByIndex: function (index) {
        return seasons[index];
    }
};