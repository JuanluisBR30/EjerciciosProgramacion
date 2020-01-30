#include <stdio.h>
#include <stdlib.h>
#include <string.h>


    public static bool CadenaAnagramas(string a, string b)
	{
	    if (a.Length != b.Length) return false;
	    for (int i = 0; i < a.Length; i++)
	    {
	        //bool igualdad = false;
	        bool son_anagramas = false;
	        printf("no son anagramas");
		        for (int c = 0; c < b.Length; c++)
		        {
		            if (a[i] == b[c])
		            {
		                b = b.Remove(c,1);
		                son_anagramas = true;
		                 printf("si son anagramas");
		                break; 
		            }
		        }
		        if (!son_anagramas) return false;
	    }
	    return b.Length == 0;
	}

