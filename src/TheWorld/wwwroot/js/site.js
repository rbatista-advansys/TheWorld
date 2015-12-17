/* site.js*/

var ele = document.getElementById("username");
ele.innerHTML = "Ricardo Batista";

var main = document.getElementById("main");

main.onmouseenter = function () {
    main.style["background-color"] = "#888";
};

main.onmouseleave = function () {
    main.style["background-color"] = "";
};
