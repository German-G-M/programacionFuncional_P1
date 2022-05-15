# -*- coding: utf-8 -*-
"""
Created on Sun May 15 17:07:35 2022

@author: germa
"""

from pyswip import Prolog
prolog=Prolog()
#relación padres
prolog.assertz("padre(juan,mario)")
prolog.assertz("padre(juan,julio)")
prolog.assertz("padre(mario,marquito)")
prolog.assertz("padre(mario,pepito)")
prolog.assertz("padre(julio,anita)")
prolog.assertz("padre(julio,rosita)")

print("RELACIÓN DE TODOS LOS PADRES")
for elemento in prolog.query("padre(X,Y)"):
    print (elemento["X"]," es el padre de ",elemento["Y"])

#relación abuelos
print("RELACIÓN DE TODOS LOS ABUELOS")
for elemento in prolog.query("padre(X,Y),padre(Y,Z)"):
    print (elemento["X"]," es el abuelo de ",elemento["Z"])
#relación nietos
print("RELACIÓN DE TODOS LOS NIETOS")
for elemento in prolog.query("padre(X,Y),padre(Y,Z)"):
    print (elemento["Z"]," es el nieto de ",elemento["X"])
#relacion primos
print("RELACIÓN DE TODOS LOS PRIMOS")
for elemento in prolog.query("padre(X,Y),padre(A,B),padre(C,X),padre(C,A),not(X==A)"):
    print (elemento["Y"]," es primo de ",elemento["B"])