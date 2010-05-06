<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ContentPlaceHolderID="body" ID="content" runat="server">
    <div class="convertForm">
		<ul>
			<li><a href="#rawJson">Raw JSON</a></li>
			<li><a href="#apiRequests">API Requests</a></li>
		</ul>
		<div id="rawJson">
			<label for="RootName">Root Name</label>
			<input id="RootName" type="text" />
			<label for="Json">JSON</label>
			<textarea id="Json"></textarea>
			<a class="convertBtn raw">Convert JSON</a>
		</div>
		<div id="apiRequests">
			<div class="apiRequest">
				<label class="apiRootName">Root Name</label>
				<label class="requestUri">Uri</label>
				<input class="apiRootName" type="text" />
				<input class="requestUri" type="text" />
			</div>
			<div class="apiRequest">
				<label class="apiRootName">Root Name</label>
				<label class="requestUri">Uri</label>
				<input class="apiRootName" type="text" />
				<input class="requestUri" type="text" />
			</div>
			<div class="apiRequest">
				<label class="apiRootName">Root Name</label>
				<label class="requestUri">Uri</label>
				<input class="apiRootName" type="text" />
				<input class="requestUri" type="text" />
			</div>
			<div class="apiRequest">
				<label class="apiRootName">Root Name</label>
				<label class="requestUri">Uri</label>
				<input class="apiRootName" type="text" />
				<input class="requestUri" type="text" />
			</div>			
			<div class="clear"></div>			
			<a class="convertBtn api">Convert JSON</a>
		</div>
	</div>
	<div id="loader" style="display: none;"><img src="/Content/Images/loading3.gif" /></div>
	<div class="previewHolder">
		<div id="primaryPreview" class="preview">
			<div class="jsonSubmitted">
				<pre></pre>
			</div>
			<div class="codeResult">
				<pre></pre>
			</div>
			<div class="clear"></div>
		</div>
	</div>
    <script type="text/javascript">
    	var $loader;
    	var $primaryPreview;

    	$(function() {
    		$(".convertForm").tabs();
    		var button = $(".convertBtn");
    		button.button();
    		$primaryPreview = $("#primaryPreview").first();
    		$loader = $("#loader");
    		$("body").addClass("minimized");
    		var content = $("#content");
    		$(".previewHolder").hide();
    		button.click(function() {
    			content.addClass("loader-container");
    			$(".convertForm").hide();
    			$loader.show();
    			if ($(this).hasClass("raw")) {
    				var json = $("#Json").val();
    				var rootName = $("#RootName").val();
    				postRaw(json, rootName);
    			}
    			else {
    				$(".apiRequest").each(function() {
    					var rootName = $(this).children("input.apiRootName").val();
    					var uri = $(this).children("input.requestUri").val();
    					postApiRequests(uri, rootName);
    				});
    				$primaryPreview.remove();
    				highlightSyntax();
    			}
    		});
    	});

    	function postRaw(json, rootName) {
    		$.ajaxSetup({ cache: false, async: true });
    		$.post("/jsonconvert/Post", { "json": json, "rootName": rootName }, function(result) {
    			$("<h2>" + result.RootName + "</h2>").insertBefore($primaryPreview);
    			setupPreview($primaryPreview, result);
    			highlightSyntax();
    		});
    	}

    	function postApiRequests(uri, rootName) {
    		if (rootName != "" && uri != "") {
    			$.ajaxSetup({ cache: false, async: false });
    			$.post("/jsonconvert/PostRequests", { "uri": uri, "rootName": rootName }, function(result) {
    				var clone = $primaryPreview.clone().appendTo($primaryPreview.parent());
    				$("<h2>" + result.RootName + "</h2>").insertBefore(clone);
    				setupPreview(clone, result);
    			});
    		}
    	}
    	
    	function setupPreview(previewDiv, result)
    	{
    		var submittedJson = previewDiv.children(".jsonSubmitted").children("pre");
    		submittedJson.html(result.Json);
    		submittedJson.addClass("brush: js; showControls: true");
    		var codeResult = previewDiv.children(".codeResult").children("pre");
    		codeResult.html(result.ConvertedCode);
    		codeResult.addClass("brush: csharp; showControls: true");
    	}

    	function highlightSyntax() {
    		$("body").removeClass("minimized");
    		SyntaxHighlighter.config.clipboardSwf = 'scripts/clipboard.swf';
    		SyntaxHighlighter.highlight();
    		$loader.hide();
    		$(".previewHolder").show();
    	}
    </script>
</asp:Content>