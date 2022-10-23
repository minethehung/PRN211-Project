﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ITaskGroupRepository
    {
        List<TaskGroupObject> GetTaskGroupList();
        List<TaskGroupObject> GetTaskGroupListByUser(string username);
        int GetTaskGroupId(string username, string groupName);
    }
}