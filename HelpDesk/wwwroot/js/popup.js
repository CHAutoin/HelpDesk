$(document).ready(function(){
	var modalbg = $(".modal-bg");
	var modalcontet = $(".modal-content");
    $("#del").click(function(){
    	modalbg.css({
    			"display": "block"
    	})
	    modalcontet.css({
	    		"display": "block"
    	})
    })
    $(".close").click(function(){
    	modalbg.css({
    			"display": "none"
    	})
	    modalcontet.css({
	    		"display": "none"
    	})
    })
})