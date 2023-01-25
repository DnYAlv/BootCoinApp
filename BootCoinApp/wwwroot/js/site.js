﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var addCoinButton = document.getElementById("add-coin-button");
var addRewardButton = document.getElementById("add-reward-button");
var logoutButton = document.getElementById("logout-button");
var addCoinText = document.getElementById("add-coin-text");
var addRewardText = document.getElementById("add-reward-text");
var logoutText = document.getElementById("logout-text");
var addCoinImage = document.getElementById("add-coin-img");
var addRewardImage = document.getElementById("add-reward-img");
var multiplePeople = document.getElementById("multiple-people");
var multipleGroup = document.getElementById("multiple-group");

var colCoinPeople = document.getElementsByClassName("col-coin-card-people");
var colCoinGroup = document.getElementsByClassName("col-coin-card-group");

//switch theme
var searchBar = document.getElementsByClassName("search-bar");
var topContainer = document.getElementsByClassName("top-container");
var title = document.getElementsByClassName("title");
var themeContainerChange = document.getElementsByClassName("theme-container-change");
var themeTextChange = document.getElementsByClassName("theme-text-change");
var themeBackgroundChange = document.getElementsByClassName("theme-background-change");

var path = window.location.pathname;
var page = path.split("/").pop();

var hoverMenu = 1;
var currMenu = 2;

var multiplePeopleSelected = false;
const peopleSelected = [];
const elementPeopleSelected = [];

var multipleGroupSelected = false;
const groupSelected = [];
const elementGroupSelected = [];

var isDark = false

if (page == "CoinPeople" || page == "CoinGroup") {
    currMenu = 1;
    changeToDefault(addRewardButton);
} else {
    currMenu = 2;
    changeToDefault(addCoinButton);
}

function changeAttribute(choosed, notChoosed, cText, ncText) {
    choosed.style.backgroundColor = "#FCCF00";
    cText.style.color = "black";
    cText.style.fontWeight = "bold";
    notChoosed.style.backgroundColor = "transparent";
    ncText.style.color = "white";
    ncText.style.fontWeight = "400";
}

function changeToDefault(unHovered) {
    let currObjectMenu = ((currMenu == 1) ? addCoinButton : addRewardButton);
    if (unHovered != currObjectMenu) {
        if (currMenu == 1) { //addCoin 
            changeAttribute(addCoinButton, addRewardButton, addCoinText, addRewardText);
            addCoinImage.src = "../assets/add-coin-black.png";
            addRewardImage.src = "../assets/add-reward-white.png";
            hoverMenu = 1;
        } else { //addReward Menu
            changeAttribute(addRewardButton, addCoinButton, addRewardText, addCoinText);
            addCoinImage.src = "../assets/add-coin-white.png";
            addRewardImage.src = "../assets/add-reward-black.png";
            hoverMenu = 2;
        }
    }
}

addCoinButton.addEventListener("mouseover", () => {
    if (hoverMenu == 2) {
        changeAttribute(addCoinButton, addRewardButton, addCoinText, addRewardText);
        addCoinImage.src = "../assets/add-coin-black.png";
        addRewardImage.src = "../assets/add-reward-white.png";
        hoverMenu = 1;
    }
})

addCoinButton.addEventListener("mouseleave", () => {
    changeToDefault(addCoinButton);
})

addRewardButton.addEventListener("mouseover", () => {
    if (hoverMenu == 1) {
        changeAttribute(addRewardButton, addCoinButton, addRewardText, addCoinText);
        addCoinImage.src = "../assets/add-coin-white.png";
        addRewardImage.src = "../assets/add-reward-black.png";
        hoverMenu = 2;
    }
})

addRewardButton.addEventListener("mouseleave", () => {
    changeToDefault(addRewardButton);
})

logoutButton.addEventListener("mouseover", () => {
    logoutButton.style.backgroundColor = "#FCCF00";
    logoutText.style.color = "black";
    logoutText.style.fontWeight = "bold";
})

logoutButton.addEventListener("mouseleave", () => {
    logoutButton.style.backgroundColor = "transparent";
    logoutText.style.color = "white";
    logoutText.style.fontWeight = "400";
})

//People
function changeColCoinPeopleAttr(element) {
    let id = element.getAttribute("data-id");
    let len = peopleSelected.length;
    let isExist = false;
    if (multiplePeopleSelected) {
        for (let i = 0; i < len; i++) {
            if (peopleSelected[i] == id) {
                isExist = true;
                var index = peopleSelected.indexOf(id);
                peopleSelected.splice(index, 1);

                index = elementPeopleSelected.indexOf(element);
                elementPeopleSelected.splice(index, 1);
            }
        }
        if (!isExist) {
            element.classList.add("selected-card");
            peopleSelected.push(id);
            elementPeopleSelected.push(element);
        } else {
            element.classList.remove("selected-card");
        }

    } else {
        if (len == 1) {
            if (peopleSelected[0] == id) {

                var index = peopleSelected.indexOf(id);
                peopleSelected.splice(index, 1);

                index = elementPeopleSelected.indexOf(element);
                elementPeopleSelected.splice(index, 1);

                element.classList.remove("selected-card");
            }
        } else {
            element.classList.add("selected-card");
            peopleSelected.push(id);
            elementPeopleSelected.push(element);
        }
    }
}

function multiplePeopleChange() {
    if (!multiplePeopleSelected) {
        multiplePeopleSelected = true;
    } else {
        //sisakan 1 selected
        let len = peopleSelected.length;
        for (let i = len; i >= 2; i--) {

            elementPeopleSelected[i - 1].classList.remove("selected-card");

            elementPeopleSelected.pop();
            peopleSelected.pop();

        }

        multiplePeopleSelected = false;
    }
}

//Group
function changeColCoinGroupAttr(element) {
    let id = element.getAttribute("data-id");
    let len = groupSelected.length;
    let isExist = false;
    if (multipleGroupSelected) {
        for (let i = 0; i < len; i++) {
            if (groupSelected[i] == id) {
                isExist = true;
                var index = groupSelected.indexOf(id);
                groupSelected.splice(index, 1);

                index = elementGroupSelected.indexOf(element);
                elementGroupSelected.splice(index, 1);
            }
        }
        if (!isExist) {
            element.classList.add("selected-card");
            groupSelected.push(id);
            elementGroupSelected.push(element);
        } else {
            element.classList.remove("selected-card");
        }

    } else {
        if (len == 1) {
            if (groupSelected[0] == id) {

                var index = groupSelected.indexOf(id);
                groupSelected.splice(index, 1);

                index = elementGroupSelected.indexOf(element);
                elementGroupSelected.splice(index, 1);

                element.classList.remove("selected-card");
            }
        } else {
            element.classList.add("selected-card");
            groupSelected.push(id);
            elementGroupSelected.push(element);
        }
    }
}

function multipleGroupChange() {
    if (!multipleGroupSelected) {
        multipleGroupSelected = true;
    } else {
        //sisakan 1 selected
        let len = groupSelected.length;
        for (let i = len; i >= 2; i--) {
                     
            elementGroupSelected[i - 1].classList.remove("selected-card");

            elementGroupSelected.pop();
            groupSelected.pop();

        }

        multipleGroupSelected = false;
    }
}

function changeTheme() {
    if (!isDark) {

        isDark = true;
        console.log("masuk dark");
        let len = 0;

        //change theme to dark
        /* changing search bar into dark mode */

        searchBar[0].classList.add("dark-mode-2");

        len = themeContainerChange.length;
        for (let i = 0; i < len; i++) {
            themeContainerChange[i].classList.add("dark-mode-1");
        }

        len = themeTextChange.length;
        for (let i = 0; i < len; i++) {
            themeTextChange[i].classList.add("dark-mode-text");
        }

        len = themeBackgroundChange.length;
        for (let i = 0; i < len; i++) {
            themeBackgroundChange[i].classList.add("dark-mode-3");
        }
    } else {

        isDark = false;
        console.log("masuk light");
        let len = 0;

        //change theme to light
        /* changing search bar into light mode */

        searchBar[0].classList.remove("dark-mode-2");

        len = themeContainerChange.length;
        for (let i = 0; i < len; i++) {
            themeContainerChange[i].classList.remove("dark-mode-1");
        }

        len = themeTextChange.length;
        for (let i = 0; i < len; i++) {
            themeTextChange[i].classList.remove("dark-mode-text");
        }

        len = themeBackgroundChange.length;
        for (let i = 0; i < len; i++) {
            themeBackgroundChange[i].classList.remove("dark-mode-3");
        }
    }
}