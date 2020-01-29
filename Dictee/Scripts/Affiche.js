

function affichermasque(correction) {
    if (document.getElementById(correction).style.visibility == "hidden") {
        document.getElementById(correction).style.visibility = "visible";
        document.getElementById('bouton_' + correction).innerHTML = 'Cacher le texte';
    }
    else {
        document.getElementById(correction).style.visibility = "hidden";
        document.getElementById('bouton_' + correction).innerHTML = 'Afficher le texte';
    }
    return true;
}
