<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ContentPlaceHolderID="body" ID="content" runat="server">
    <div class="convertForm">
		<label for="RootName">Root Name</label>
		<input id="RootName" type="text" />
		<label for="Json">JSON</label>
		<textarea id="Json"></textarea>
		<span class="btn4"><a id="convert-btn">Convert JSON</a></span>
	</div>
	<div id="loader" style="display: none;"><img src="/Content/Images/loading3.gif" /></div>
	<div class="preview">
		<div id="jsonSubmitted">
			<h2>JSON</h2>
			<pre class="brush: js; showControls: true"></pre>
		</div>
		<div id="codeResult">
			<h2>C#</h2>
			<pre class="brush: csharp; showControls: true"></pre>
		</div>
    </div>
    <script type="text/javascript">
    	$(function() {
    		$("body").addClass("minimized");
    		var content = $("#content");
    		$(".preview").hide();
    		$("#convert-btn").click(function() {
    			content.addClass("loader-container");
    			var loader = $("#loader");
    			$(".convertForm").hide();
    			loader.show();
    			$.ajaxSetup({ cache: false, async: true });
    			var json = $("#Json").val();
    			var rootName = $("#RootName").val();
    			$.post("/jsonconvert/Post", { "json": json, "rootName": rootName }, function(result) {
    				loader.hide();
    				$("#jsonSubmitted pre").html(result.Json);
    				$("body").removeClass("minimized");
    				$("#codeResult pre").html(result.ConvertedCode);
    				SyntaxHighlighter.config.clipboardSwf = 'scripts/clipboard.swf';
    				SyntaxHighlighter.highlight();
    				$(".preview").show();
    			});
    		});
    	});
    </script>
</asp:Content>