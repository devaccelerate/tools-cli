﻿// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Profiles.EF;
using Ejyle.DevAccelerate.Profiles.EF.UserProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Tools.Core.Commands
{
    public class DaCreateProfilesPlansCommand : IDaCommand
    {
        public DaCommandResult Execute()
        {
            var userProfileManager = new DaUserProfileManager(new DaUserProfileRepository(new DaProfilesDbContext()));

            userProfileManager.FindById(1);

            var messages = new List<DaCommandResultMessage>();
            messages.Add(new DaCommandResultMessage(DaCommandResultMessageType.Info, $"Executed a query against the user profiles."));
            
            return new DaCommandResult(true, messages);
        }
    }
}
