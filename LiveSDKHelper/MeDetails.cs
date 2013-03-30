﻿using System;
using System.Runtime.Serialization;
using LiveSDKHelper.SkyDrive;

namespace LiveSDKHelper
{
    [DataContract]
    public class MeDetails
    {
        [DataMember(Name= "id")]
        public string Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "first_name")]
        public string FirstName { get; set; }
        [DataMember(Name = "last_name")]
        public string LastName { get; set; }
        [DataMember(Name = "link")]
        public string Link { get; set; }
        [DataMember(Name = "gender")]
        public object Gender { get; set; }
        [DataMember(Name = "locale")]
        public string Locale { get; set; }
        [DataMember(Name = "updated_time")]
        public DateTime UpdatedTime { get; set; }
        
        public string CameraRollFolder
        {
            get { return SkyDriveHelper.GetCameraRollFolder(LiveSdkConstants.MyDetails); }
        }

        public string MyDocumentsFolder
        {
            get { return SkyDriveHelper.GetMyDocumentsFolder(LiveSdkConstants.MyDetails); }
        }

        public string MyPhotosFolder
        {
            get { return SkyDriveHelper.GetMyPhotosFolder(LiveSdkConstants.MyDetails); }
        }

        public string PublicDocumentsFolder
        {
            get { return SkyDriveHelper.GetPublicDocumentsFolder(LiveSdkConstants.MyDetails); }
        }
    }
}