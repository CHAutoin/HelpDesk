$(document).ready(function(){

	var table = $("#table");
		


		// Table striped
		var striped = $("#striped");
		var stri = document.getElementById('st');
			striped.change(function(){
				if (striped.is(":checked") == true) {
					table.addClass("table-striped");
					stri.innerHTML = "เปิด";
				}else{
					table.removeClass("table-striped");
					stri.innerHTML = "ปิด";
				}
			});

		var tes = $("#hover");
		var hov = document.getElementById('hov');
			tes.change(function(){
				if (tes.is(":checked") == true) {
					table.addClass("table-hover");
					hov.innerHTML = "เปิด";
				}else{
					table.removeClass("table-hover");
					hov.innerHTML = "ปิด";
				}
			});

			//Table bordered
		var bor = $("#bordered");
		var l = document.getElementById('l');
			bor.change(function(){
				if (bor.is(":checked") == true) {
					table.addClass("table-bordered");
					l.innerHTML = "ปิด";
				}else{
					table.removeClass("table-bordered");
					l.innerHTML = "เปิด";
				}
			});


		//Table Color
	    $('#table-color').change(function() {
	        var value = $(this).val();
	        table.removeClass(/^table-mc-/).addClass(value);
	    });
});
	    (function(removeClass){
	    	jQuery.fn.removeClass = function(value){
	    		if (value && typeof value.test === "function") {
	    			for(var i=0, l = this.length; i < l; i++){
	    				var elem = this[i];
	    				if(elem.nodeType === 1 && elem.className){
	    					var className = elem.className.split(/\s+/);

	    					for(var n = className.length; n--;){
	    						if(value.test(className[n])){
	    							className.splice(n, 1);
	    						}
	    					}
	    					elem.className = jQuery.trim(className.join(" "));
	    				} 
	    			}
	    		}else{
	    			removeClass.call(this, value);
	    		}
	    		return this;
	    	}
	    })(jQuery.fn.removeClass);
