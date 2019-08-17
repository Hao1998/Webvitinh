var user = {
    init: function () {
        user.loadProvince();
    },
    registerEvent: function () {
        var html = '';
    },
    loadProvince: function () {
        var html = '';
        $.ajax({
            url: '/User/LoadProvince',
            type: "POST",
            dataType: "json",
            success: function (response) {
                if (response.status == true)
                {
                    alert('1');
                }
            }
        })
    }
}
user.init();