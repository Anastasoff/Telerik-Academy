var categories = [
    'Academy initiative',
    'Free time',
    'Party time',
    'Walk in the park',
    'In the club'
];

module.exports = {
    getAllCategories: function () {
        return categories;
    },
    getCategoryByIndex: function (index) {
        return categories[index];
    }
};