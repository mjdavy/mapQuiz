#pragma checksum "C:\Users\mjdav\source\repos\mjdavy\mapQuiz\Pages\Quiz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33164419e92facf1dcea4928b7becb00abb05849"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(mapQuiz.Pages.Pages_Quiz), @"mvc.1.0.razor-page", @"/Pages/Quiz.cshtml")]
namespace mapQuiz.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mjdav\source\repos\mjdavy\mapQuiz\Pages\_ViewImports.cshtml"
using mapQuiz;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33164419e92facf1dcea4928b7becb00abb05849", @"/Pages/Quiz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5701b31180e7d700dc22a55896fa5553550cbc27", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Quiz : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mjdav\source\repos\mjdavy\mapQuiz\Pages\Quiz.cshtml"
  
    ViewData["Title"] = "Quiz";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
table {
  font-family: arial, sans-serif;
  border-collapse: collapse;
}

td, th {
  text-align: left;
  padding: 8px;
}
</style>

<script>
function BuildMapNameLookup() 
{
    stateNames['AL'] = 'Alabama';
    stateNames['AK'] = 'Alaska';
    stateNames['AZ'] =	'Arizona';
    stateNames['AR'] =	'Arkansas';
    stateNames['CA'] =	'California';
    stateNames['CO'] =	'Colorado';
    stateNames['CT'] =	'Connecticut';
    stateNames['DE'] =	'Delaware';
    stateNames['FL'] =	'Florida';
    stateNames['GA'] =	'Georgia';
    stateNames['HI'] =	'Hawaii';
    stateNames['ID'] =	'Idaho';
    stateNames['IL'] =	'Illinois';
    stateNames['IN'] =	'Indiana';
    stateNames['IA'] =	'Iowa';
    stateNames['KS'] =	'Kansas';
    stateNames['KY'] =	'Kentucky';
    stateNames['LA'] =	'Louisiana';
    stateNames['ME'] =	'Maine';
    stateNames['MD'] =	'Maryland';
    stateNames['MA'] =	'Massachusetts';
    stateNames['MI'] =	'Michigan';
    stateNames['MN'] =	'Minnesota';
    sta");
            WriteLiteral(@"teNames['MS'] =	'Mississippi';
    stateNames['MO'] =	'Missouri';
    stateNames['MT'] =	'Montana';
    stateNames['NE'] =	'Nebraska';
    stateNames['NV'] =	'Nevada';
    stateNames['NH'] =	'New Hampshire';
    stateNames['NJ'] =	'New Jersey';
    stateNames['NM'] =	'New Mexico';
    stateNames['NY'] =	'New York';
    stateNames['NC'] =	'North Carolina';
    stateNames['ND'] =	'North Dakota';
    stateNames['OH'] =	'Ohio';
    stateNames['OK'] =	'Oklahoma';
    stateNames['OR'] =	'Oregon';
    stateNames['PA'] =	'Pennsylvania';
    stateNames['RI'] =	'Rhode Island';
    stateNames['SC'] =	'South Carolina';
    stateNames['SD'] =	'South Dakota';
    stateNames['TN'] =	'Tennessee';
    stateNames['TX'] =	'Texas';
    stateNames['UT'] =	'Utah';
    stateNames['VT'] =	'Vermont';
    stateNames['VA'] =	'Virginia';
    stateNames['WA'] =	'Washington';
    stateNames['WV'] =	'West Virginia';
    stateNames['WI'] =	'Wisconsin';
    stateNames['WY'] =	'Wyoming';
}

var getAnswer = false;");
            WriteLiteral(@"
var rightAnswers = 0
var wrongAnswers = 0;
var quizIndex = 0;
var quizState;
var stateNames = {};
var allStates = ['AL','AK','AZ','AR','CA','CO','CT','DE','FL','GA','HI','ID','IL','IN','IA','KS','KY','LA','ME','MD','MA','MI','MN','MO','MS','MT','NE','NV','NH','NJ','NM','NY','NC','ND','OH','OK','OR','PA','RI','SC','SD','TN','TX','UT','VT','VA','WA','WV','WI','WY'];
BuildMapNameLookup();

function shuffleArray(array) {
  let curId = array.length;
  // There remain elements to shuffle
  while (0 !== curId) {
    // Pick a remaining element
    let randId = Math.floor(Math.random() * curId);
    curId -= 1;
    // Swap it with the current element.
    let tmp = array[curId];
    array[curId] = array[randId];
    array[randId] = tmp;
  }
  return array;
}

function startQuiz()
{
  allStates = shuffleArray(allStates);
  quizIndex = 0;
  rightAnswers = 0;
  wrongAnswers = 0;
  updateScores();
  $('#nextQuestion').text(""Start"");
  $('#question').text(""Click start button to begin"");
}");
            WriteLiteral(@"

function randomState()
{
  if (quizIndex >= 50)
  {
    showFinalResults();
  }
  return allStates[quizIndex++];
}

function prompt()
{
  quizState = randomState();
  promptText = ""Find "" + stateNames[quizState] + "":"";
  $('#question').text(promptText);
  $('#mapquizAnswer').text('');
  $('#nextQuestion').text(""Next"");
  getAnswer = true;
  document.getElementById(""nextQuestion"").disabled = true;
}

function initialize()
{
   $('#map').usmap({

    'click' : function(event, data) {
        
        var answerBG = 'red';

        if (!getAnswer) return;

        if (data.name == quizState)
        {
          answerBG = 'green';
          $('#mapquizAnswer')
          .text('Correct!')
          .stop()
          .css('backgroundColor', answerBG)
          .animate({backgroundColor: 'white'}, 1000);
          rightAnswers++;
        }
        else
        {
          var correctState = ""No, that was "" + stateNames[data.name];
          
          $('#mapquizAnswer");
            WriteLiteral(@"')
          .text(correctState)
          .stop()
          .css('backgroundColor', answerBG)
          .animate({backgroundColor: 'white'}, 1000);
          wrongAnswers++;
        }

        this.stateSpecificStyles[data.name] = {fill: answerBG};
        
        
        updateScores();
        getAnswer = false;
        document.getElementById(""nextQuestion"").disabled = false;
    }
    });
}

function updateScores()
{
  var total = rightAnswers + wrongAnswers;
  var score = 0;

  if (total > 0)
  {
    score = Math.round(rightAnswers / total*100);
  }

  $('#score').text(""Score: "" + score + ""%"");
}

function showFinalResults() {
  
  if (rightAnswers == 50)
  {
    var message = ""Awesome!"";
  }
  else if (rightAnswers > 25)
  {
    var message = ""Well done!"";
  }
  else
  {
     var message = ""Keep studying!"";
  }
  $('#finalResults').text(message);
  document.getElementById(""overlay"").style.display = ""block"";
}

function hideFinalResults() {
  document.");
            WriteLiteral(@"getElementById(""overlay"").style.display = ""none"";
  window.location.href = window.location.origin;
}

$(document).ready(function() {
  initialize();
  startQuiz(); 
});
</script>

<style>
  td {
    font-size: 200%;
  }
  #score {
    text-align: right;
  }
  button {
    border-radius: 10px;
    float: right;
    margin-top: 12px;
    font-size: 200%;
    background-color: blue;
    color: white;
  }
  button:disabled,
  button[disabled] {
    border: 1px solid #999999;
    background-color: #cccccc;
    color: #666666;
  }
  #overlay {
    position: fixed; /* Sit on top of the page content */
    display: none; /* Hidden by default */
    width: 100%; /* Full width (cover the whole page) */
    height: 100%; /* Full height (cover the whole page) */
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background-color: rgba(0,0,0,0.5); /* Black background with opacity */
    z-index: 2; /* Specify a stack order in case you're using a different order for other ele");
            WriteLiteral(@"ments */
    cursor: pointer; /* Add a pointer on hover */
  }
  #finalResults{
    position: absolute;
    top: 50%;
    left: 50%;
    font-size: 50px;
    color: white;
    transform: translate(-50%,-50%);
    -ms-transform: translate(-50%,-50%);
  }
</style>

<div>
  <table width=930px>
      <td id=question></td>  
      <td id=mapquizAnswer></td>
      <td id=score></td>  
  </table>
</div>
<div id=""map"" style=""width: 930px; height: 630px; border: solid 3px blue;"">
  <p><button class=""button"" id=""nextQuestion"" type=""button"" onclick=""prompt()"">Next</button></p>
</div>
<div id=""overlay"" onclick=""hideFinalResults()"">
  <div id=""finalResults""></div>
</div>

  
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuizModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuizModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuizModel>)PageContext?.ViewData;
        public QuizModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
