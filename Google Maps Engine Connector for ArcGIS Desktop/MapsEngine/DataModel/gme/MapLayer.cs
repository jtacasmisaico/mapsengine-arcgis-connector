﻿/*
Copyright 2013 Google Inc

Licensed under the Apache License, Version 2.0(the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.google.mapsengine.connectors.arcgis.MapsEngine.DataModel.gme
{
    /*
     * A Google Maps Engine map layer entity.
     */
    public class MapLayer
    {
        // The ID of the layer.
        private string _id;

        //constructor
        public MapLayer() { }

        #region Getters/Setters

        public String id
        {
            get { return this._id; }

            set { if (this._id != value) this._id = value; }
        }

        #endregion
    }
}
