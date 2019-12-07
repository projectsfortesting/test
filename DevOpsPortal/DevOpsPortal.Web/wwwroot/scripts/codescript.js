var toggler = document.getElementsByClassName("caret");
var i;

for (i = 0; i < toggler.length; i++) {
    toggler[i].addEventListener("click", function () {
        this.parentElement.querySelector(".nested").classList.toggle("active");
        this.classList.toggle("caret-down");
    });
}

var $$ = go.GraphObject.make;
myDiagram = $$(go.Diagram, "myDiagramDiv",
    {

        "undoManager.isEnabled": true
    });

myDiagram.nodeTemplate =
   $$(go.Node, "Spot",
        new go.Binding("location", "loc", go.Point.parse).makeTwoWay(go.Point.stringify),
       $$(go.Shape, "RoundedRectangle",
           { fill: "#222d32", width: 85, height: 25, stroke: "#008080" },
            {
                portId: "",
                fromSpot: go.Spot.Right,  // port properties go on the port!
                toSpot: go.Spot.Left,
                fromLinkable: true,
                toLinkable: true,
                cursor: "crosshair",
                fromLinkableDuplicates: false,
                toLinkableDuplicates: false
            }
           ),
       $$(go.TextBlock, { stroke: "#FFFFFF", font: '11px Arial',width: 80,wrap: go.TextBlock.WrapFit, textAlign: "center"},
            new go.Binding("text", "key"))
    );

myDiagram.linkTemplate =
   $$(go.Link,  // the whole link panel
        new go.Binding("points").makeTwoWay(),
        {
            curve: go.Link.Bezier,
            toShortLength: 15,
            routing: go.Link.AvoidsNodes,       // Orthogonal routing
            corner: 10
        },
       $$(go.Shape,  // the link shape
        { stroke: "#888", strokeWidth: 3 }),
       $$(go.Shape,  // the arrowhead
           { fromArrow: "block", fill: "#ccc", stroke: "#888", strokeWidth: 0.5, scale: 1 }),
       $$(go.Shape,  // the arrowhead
           { toArrow: "block", fill: "#ccc", stroke: "#888", strokeWidth: 0.5, scale: 1 })
    );
// create the Palette
myPalette = new go.Palette("myPaletteLevel1");
// the Palette's node template is different from the main Diagram's
myPalette.nodeTemplate =
   $$(go.Node, "Auto", 
       $$(go.Shape, "RoundedRectangle",
            { fill: "#222d32", width: 85, height: 25, stroke: "#008080" }
        ),
       $$(go.TextBlock, {
           stroke: "#FFFFFF", font: '11px Arial', width: 80,wrap: go.TextBlock.WrapFit, textAlign: "center"},
            new go.Binding("text", "key"))
    );

// the list of data to show in the Palette
myPalette.model.nodeDataArray = [
    { key: "Checkout", ToolName: "Gerrit", Url: "http://gerrrit:8080", UserName: "devopsuser", Password: "devopspwd", BranchName: "master"},
    { key: "Build", ToolName: "Maven", Goal: "Clean Compile"},
    { key: "UnitTest", ToolName: "Junit", Goal: "test"},
    { key: "Static Analysis", ToolName: "SonarQube", ProjectName: "game-of-life-ci-pipeline",ProjectKey: "game-of-life-ci-pipeline",Modules: "gameoflife-core,gameoflife-web",
        gameoflife_core_sonar_java_binaries: "target/classes",gameoflife_core_sonar_sources: "src/main",gameoflife_core_sonar_tests: "src/test",
        gameoflife_core_sonar_junit_reportsPath: "/target/surefire_reports",gameoflife_core_sonar_jacoco_reportPath: "target/jacoco_exec"},
    { key: "Code Coverage",ToolName: "Jacoco"},
    { key: "Unit Test Gate",ToolName: "Xunit",WarningThreshold: "",ErrorLimit: ""},
    { key: "Static Analysis Gate",ToolName: "SonarQube"},
    { key: "Code Coverage Gate",ToolName: "Jacoco",WarningThreshold: "",ErrorLimit: ""},
    { key: "Report Unit Test",ToolName: "Junit"},
    { key: "Report Code Coverage",ToolName: "html publisher reports"},
    { key: "Notification Email", ToolName: "Email", EmailAddress: "" }
];


var inspector = new Inspector('myInspectorDiv', myDiagram,
    {
        // allows for multiple nodes to be inspected at once
        multipleSelection: false,
        includesOwnProperties: false,
        showAllProperties: true,
        properties: {
            // key would be automatically added for nodes, but we want to declare it read-only also:
            //"ToolName" :{ show: Inspector.showIfNode, type: "select", choices: ["Gerrit", "Gitlab", "GitHub"] },
            "ToolName": { show: Inspector.showIfPresent, readOnly: true },
            "Url": { show: Inspector.showIfPresent, type: 'string' },    
            "ProjectName": { show: Inspector.showIfPresent, type: 'string' },
            "ProjectKey": { show: Inspector.showIfPresent, type: 'string' },
            "Modules": { show: Inspector.showIfPresent, type: 'string' },
            "gameoflife_core_sonar_java_binaries": { show: Inspector.showIfPresent, type: 'string' },
            "gameoflife_core_sonar_sources": { show: Inspector.showIfPresent, type: 'string' },
            "gameoflife_core_sonar_tests": { show: Inspector.showIfPresent, type: 'string' },
            "gameoflife_core_sonar_junit_reportsPath": { show: Inspector.showIfPresent, type: 'string' },
            "gameoflife_core_sonar_jacoco_reportPath": { show: Inspector.showIfPresent, type: 'string' },
            "UserName": { show: Inspector.showIfPresent, type: 'string' },
            "BranchName": { show: Inspector.showIfPresent, type: 'string' },
            "Goal": { show: Inspector.showIfPresent, type: 'string' },
            "WarningThreshold":{ show: Inspector.showIfPresent, type: 'number' },
            "ErrorLimit": { show: Inspector.showIfPresent, type: 'number' },
            "EmailAddress": { show: Inspector.showIfPresent, type: 'string' },
            "Password": { show: Inspector.showIfPresent, type: 'password' },
            "VersionNumber": { show: Inspector.showIfPresent, type: 'string' },
            "No_of_Instances": { show: Inspector.showIfPresent, type: 'number' }
        }
        
    });

myDiagram.addDiagramListener("ObjectDoubleClicked", function (ev) {
    $("#myPropertyModalheader").text(" Properties: "+ev.subject.part.data.key);
    $("#myPropertyModal").show();

});


//myDiagram.addDiagramListener("", function (ev) {
//    if (ev.subject.part.data.ToolName == "Gerrit") {
//        myDiagram.model.findNodeDataForKey("Checkout").addArrayItem({ Url: "http://gerrrit:8080", UserName: "devopsuser", Password: "devopspwd", BranchName: "master" });
//        alert(myDiagram.model.toJson());
//    }
//});


function closebtn() {
    $("#myPropertyModal").hide();
}
var modalText;
function save() {
    modalText = myDiagram.model.toJson();
    alert(modalText);
    $.ajax({
        url: "ParseJson",
        type: "Post",
        data: { PipeLineFlow:modalText },
        success: function (response) {
            alert("File Created Successfully");
        }
    });
}
function load() {
    var div = document.getElementById("myDiagramDiv");
    myDiagram.model = go.Model.fromJson(modalText);
}

