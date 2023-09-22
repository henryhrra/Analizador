// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

//const { htmlPrefilter } = require("jquery");

// Write your Javascript code.
var cadena = "";
var espacios = "";
var numeroVocales = [];
var numeroConsonantes = [];
var num = [];
var numeroMayusculas = [];
var numeroMinusculas = [];
var otro = [];
var otroE;
var conOtro;

var con = document.getElementById("con");
var voc = document.getElementById("voc");
var may = document.getElementById("may");
var min = document.getElementById("min");
var nun = document.getElementById("nun");
var oto = document.getElementById("oto");
var pal = document.getElementById("pal");

$("#Analizer").click(function () {
    cadena = document.getElementById('string').value;
    console.log(cadena);

    numeroVocales = cadena.match(/[aeiouáéíóú]/gi);
    numeroConsonantes = cadena.match(/[bcdfghjklmnñpqrstvwxys]/gi);
    num = cadena.match(/\d+/g);
    numeroMayusculas = cadena.match(/[ABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚ]/g);

    otroE = cadena.replace(/[áéíóú]/gi, '');
    otroE = otroE.replace(/ /g, "");
    otro = otroE.match(/\W+/gi);
    numeroMinusculas = cadena.match(/[abcdefghijklmnñopqrstuvwxyzáéíóú]/g);

        if (numeroVocales != null) {
            //numeroVocales = numeroVocales.length;
            voc.innerHTML = "" + numeroVocales.length;
        }
        if (numeroConsonantes != null) {
            //numeroConsonantes = numeroConsonantes.length;
            con.innerHTML = "" + numeroConsonantes.length;
        }
        if (num != null) {
            //num = num.length;
            nun.innerHTML = "" + num.length;
        }
        if (numeroMayusculas != null) {
            //numeroMayusculas = numeroMayusculas.length;
            may.innerHTML = "" +  numeroMayusculas.length;
        }
        if (numeroMinusculas != null) {
            //numeroMinusculas = numeroMinusculas.length;
            min.innerHTML = "" + numeroMinusculas.length;
        }
        if (otro != null) {
                conOtro = otro.length;
                console.log(conOtro);
                console.log(otro);
                for (let i = 0; i < otro.length; i++) {
                
                    if (otro[i].includes('ñ'))
                    conOtro--;
                    console.log("prueba");
                    console.log(conOtro);
                }
                oto.innerHTML = conOtro;
            }

    
    contar_palabras();
    console.log("Consonantes = " + numeroConsonantes);
    console.log("voacales = " + numeroVocales);
    console.log("Mayusculas = " + numeroMayusculas);
    console.log("Minusculas = " + numeroMinusculas);
    console.log("Numeros = " + num);
})
function contar_palabras() {
    var texto = document.getElementById("string").value;
    texto = texto.replace(/\r?\n/g, " ");
    texto = texto.replace(/[ ]+/g, " ");
    texto = texto.replace(/^ /, "");
    texto = texto.replace(/ $/, "");
    var resultado = texto.split(" ");
    if (resultado != null) {
        console.log("palabras = " + resultado);
        pal.innerHTML = "" + resultado.length;
    }

    /*var numeroPalabras = resultado.length;
    console.log("palabras = " + numeroPalabras);
    pal.innerHTML = "" + numeroPalabras;*/
}
