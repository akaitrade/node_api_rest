﻿using CS.Db.Models.Rest;
using System.Collections.Generic;

namespace CS.Service.RestApiNode
{
    public class AuthDataService
    {
        private static List<RestUserEntity> listAuthKey;

        public static List<RestUserEntity> ListAuthKey
        {
            get
            {
                if (listAuthKey == null || listAuthKey.Count == 0)
                {
                    listAuthKey = new List<RestUserEntity>{
                        new RestUserEntity() { ID = 1, AuthKey = "87cbdd85-b2e0-4cb9-aebf-1fe87bf3afdd", IsActive = true, Name = "Wallet" },
                        new RestUserEntity() { ID = 2, AuthKey = "7260f3b2-d311-4ccd-9b52-9da3b7d3ea72", IsActive = true, Name = "Monitor" },
                        new RestUserEntity() { ID = 3, AuthKey = "", IsActive = true, Name = "User1" },//AuthKey = "6e253096-621d-4051-96f8-d47cedbe4a0a"
                        new RestUserEntity() { ID = 4, AuthKey = "1336d53d-595e-4089-958d-57c7c2297962", IsActive = true, Name = "User2" },
                        new RestUserEntity() { ID = 5, AuthKey = "1ceb33f9-51e9-4a81-a23c-e8bfc9d40d4d", IsActive = true, Name = "User3" },
                        new RestUserEntity() { ID = 6, AuthKey = "759c9975-660c-4ded-bafa-f85e6b584544", IsActive = true, Name = "User4" },
                        new RestUserEntity() { ID = 7, AuthKey = "10b248d7-570f-4ebf-b32f-33f1e02748ac", IsActive = true, Name = "User5" },
                        new RestUserEntity() { ID = 8, AuthKey = "1ddb1f68-31fc-4fc3-99d6-9726a87a8535", IsActive = true, Name = "User6" },
                        new RestUserEntity() { ID = 9, AuthKey = "b7da5c46-c65b-4917-b403-44dedfd7a4b3", IsActive = true, Name = "User7" },
                        new RestUserEntity() { ID = 10, AuthKey = "e3659e24-8f92-468a-a10b-a6439cbe9d91", IsActive = true, Name = "User8" },
                        new RestUserEntity() { ID = 11, AuthKey = "39e5286d-c411-4fce-b95a-58d2f7d69d86", IsActive = true, Name = "User9" }
                    };
                }

                return listAuthKey;
            }
        }
    }
}
