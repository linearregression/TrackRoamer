﻿/*
 * Copyright (c) 2015..., Sergei Grichine   http://trackroamer.com
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

namespace Trackroamer.Library.LibHandHardware
{
    public interface IBrickConnector
    {
        void Open(string args, int param);
        void Close();

        void setShoulderPan(double degreesFromCenter);
        void setShoulderTilt(double degreesFromCenter);
        void setShoulderTurn(double degreesFromCenter);
        void setElbowAngle(double degreesFromCenter);
        void setThumb(double degreesFromCenter);
        void setIndexFinger(double degreesFromCenter);
        void setMiddleFinger(double degreesFromCenter);
        void setPinky(double degreesFromCenter);
        void setWristTurn(double degreesFromCenter);

        void setShoulderPanMks(int panMks);

        double currentShoulderPan { get; }
        double currentShoulderTilt { get; }
        double currentShoulderTurn { get; }
        double currentElbowAngle { get; }
        double currentThumb { get; }
        double currentIndexFinger { get; }
        double currentMiddleFinger { get; }
        double currentPinky { get; }
        double currentWristTurn { get; }

        int shoulderPanMksLast { get; }
        int shoulderTiltMksLast { get; }
        int shoulderTurnMksLast { get; }
        int elbowAngleMksLast { get; }
        int thumbMksLast { get; }
        int indexFingerMksLast { get; }
        int middleFingerMksLast { get; }
        int pinkyMksLast { get; }
        int wristTurnMksLast { get; }
    }
}
