var objMessages = {
    MessageType: {
        Success: 'success',
        Error: 'error',
        Warning: 'warning'
    },
    Think: function () {
        $("#blackLayout").fadeIn(250);
    },
    UnThink: function () {
        $("#blackLayout").fadeOut(250);
    },
    DisplayError: function (msg, isSticky, severity, duration) {
        $().toastmessage('showToast', {
            text: msg,
            sticky: isSticky,
            type: severity,
            stayTime: duration
        });

        this.UnThink();
    }
};
var objGoldAnimation = {
	Init: function(){
		
	},
	Stop:function(){}
};