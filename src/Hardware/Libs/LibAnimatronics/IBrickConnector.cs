﻿/*
 * Copyright (c) 2013..., Sergei Grichine   http://trackroamer.com
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at 
 *    http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *    
 * this is a no-warranty no-liability permissive license - you do not have to publish your changes,
 * although doing so, donating and contributing is always appreciated
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trackroamer.Library.LibAnimatronics
{
    public interface IBrickConnector
    {
        void Open(string args);
        void Close();

        /// <summary>
        /// preferred method for pan/tilt control
        /// </summary>
        /// <param name="panDegreesFromCenter"></param>
        /// <param name="tiltDegreesFromCenter"></param>
        void setPanTilt(double panDegreesFromCenter, double tiltDegreesFromCenter);

        void setPan(double degreesFromCenter);

        void setPanMks(int panMks);

        void setTilt(double degreesFromCenter);

        void setJaw(double degreesFromCenter);

        void setTiltMks(int tiltMks);

        void setJawMks(int tiltMks);

        double currentPan { get; }
        double currentTilt { get; }
        double currentJaw { get; }

        int panMksLast { get; }
        int tiltMksLast { get; }
        int jawMksLast { get; }

        void clearAnimations();
        void setDefaultAnimations();
        void setAnimation(Animation anim, double scale = 1.0d, bool doRepeat = false);
    }
}
