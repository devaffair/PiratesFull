$(".clear").click(function(){
	$(".screen").html("");
});
$(".eval").click(function(){
	var numOfPirates = parseInt($(".screen").html());
	
	if (isNaN(numOfPirates) || numOfPirates == 0) {
		objMessages.DisplayError("Put a real number, ye scurvy dogs!", false, objMessages.MessageType.Error, 2000);
		$(".screen").html("");
		return false;
	}
	
	if (numOfPirates == 1){
		objMessages.DisplayError("You are not alone matey!", false, objMessages.MessageType.Warning, 2000);
		$(".screen").html("");
		return false;
	}
	objMessages.Think();
	
	$.getJSON("http://pirate.azurewebsites.net/api/Pirate/" + numOfPirates, function(data){
		objMessages.UnThink();
		console.log(data);
		objMessages.DisplayError(data + " doubloons o' gold. Grog for everyone.", false, objMessages.MessageType.Success, 4500);
	});
});
$(".keys span").click(function(){
	if ($(this).hasClass("eval")) return false;
	
	var num = $(this).text();
	$(".screen").html($(".screen").html() + num);
});