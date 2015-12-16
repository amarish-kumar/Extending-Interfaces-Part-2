using System;
using System.Collections.Generic;
using RepositorPatternDemo.Interfaces;
using RepositorPatternDemo.Repositories;
using RepositorPatternDemo.ViewModels;

namespace UI
{
   public static class RepositoryFactory
    {
       public static IMovieRepo GetMovieRepo(string repoType)
       {
           IMovieRepo movieRepo = null;

           switch (repoType)
           {
               case "Azure":
                   movieRepo = new AzureRepo();
                   break;
               case "AWS":
                   movieRepo = new AWSRepo();
                   break;
               case "SQL":
                   movieRepo = new SQLRepo();
                   break;
               default:
                   throw new ArgumentException("Invalid Repo Type");
                   
           }
           return movieRepo;
       }
    }

   
}
