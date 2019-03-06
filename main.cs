using System;
using System.Collections.Generic;

public static class Kata
{
  public static List<int> PascalsTriangle(int n) {
    var triangle = new List<List<int>>();
    // init triangle avec des 1
    for(int i = 0; i < n; i++)
    { 
      var row = new List<int>();
      for(int j = 0; j <= i; j++)
      {
        row.Add(1);
      }    
      triangle.Add(row);
    }
    // calcul pascal
    for(int i = 1; i < n-1; i++)
    { 
      for(int j = 0; j < i; j++)
      {
          triangle[i+1][j+1] = triangle[i][j] + triangle[i][j+1];
      }    
    }
    // remise dans un seul tableau
    var liste = new List<int>();
    for(int i = 0; i < n; i++)
    { 
      for(int j = 0; j <=i; j++)
      {
          liste.Add(triangle[i][j]);
      }    
    }
    return liste;
  }
} 
