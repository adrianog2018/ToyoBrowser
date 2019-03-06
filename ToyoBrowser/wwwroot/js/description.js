new Vue({
    el: '#search',
    data: {
        search: ''
    },
    methods: {
        onSubmit: function (event) {
            var search = this.$data.search;
            if (search.length < 3) {
                event.preventDefault();
                alert('Please enter a minimum of 3 letters');
            }
        }
    }
})