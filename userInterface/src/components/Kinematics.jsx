import { Unity, useUnityContext } from "react-unity-webgl";
import { useState, useEffect } from "react";
import "./Introduction.css"
import { Link } from "react-router-dom";
import { backArrowIcon } from "../assets";
import Simulator from "../hoc/Simulators";

const Kinematics = () => {
    return (
        Simulator("cannonBall//cannon-module-v1.1")
    )
}

export default Kinematics