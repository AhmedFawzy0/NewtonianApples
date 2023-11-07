import { Unity, useUnityContext } from "react-unity-webgl";
import { useState, useEffect } from "react";
import "../components/Introduction.css"
import { Link } from "react-router-dom";
import { backArrowIcon } from "../assets";

// path takes in the path for the directory that contains
// all the WebGL configuration files
const Simulator = (path, classname = "simulation") => {
    // We'll use a state to store the device pixel ratio.
    const [devicePixelRatio, setDevicePixelRatio] = useState(
        window.devicePixelRatio
    );

    useEffect(
        function () {
            // A function which will update the device pixel ratio of the Unity
            // Application to match the device pixel ratio of the browser.
            const updateDevicePixelRatio = function () {
                setDevicePixelRatio(window.devicePixelRatio);
            };
            // A media matcher which watches for changes in the device pixel ratio.
            const mediaMatcher = window.matchMedia(
                `screen and (resolution: ${devicePixelRatio}dppx)`
            );
            // Adding an event listener to the media matcher which will update the
            // device pixel ratio of the Unity Application when the device pixel
            // ratio changes.
            mediaMatcher.addEventListener("change", updateDevicePixelRatio);
            return function () {
                // Removing the event listener when the component unmounts.
                mediaMatcher.removeEventListener("change", updateDevicePixelRatio);
            };
        },
        [devicePixelRatio]
    );


    const { unityProvider } = useUnityContext({
        loaderUrl: `${path}.loader.js`,
        dataUrl: `${path}.data`,
        frameworkUrl: `${path}.framework.js`,
        codeUrl: `${path}.wasm`,
    });

    return (
        <div className="simulator">
            <Link to={"/"} className="returnHome">
                <img src={backArrowIcon} alt="toHome" 
                className="backToHomeBtn"/>
            </Link>
            <Unity unityProvider={unityProvider} 
            className={`${classname}`}
            devicePixelRatio={devicePixelRatio} />
        </div>
    )
}

export default Simulator