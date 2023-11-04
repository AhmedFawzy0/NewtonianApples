import { useState } from "react";
import SectionWrapper from "../hoc/SectionWrapper";
import "./Introduction.css"
import SideMenu from "./SideMenu";
import { apple } from "../assets";

const Introduction = () => {
    return (
        <div className="introduction">
            <div className="project-name-background">
                <h1 className="introduction-appName">
                    Newtonian Apples
                </h1>
                <img src={apple} alt="appleIcon" className="project-icon"/>
            </div>
            <div className="introduction-content">
                <h2>
                    Simulation Topics
                </h2>

                <div className="introduction-topics">

                </div>
            </div>
        </div>
    )
}

const SearchBar = () => {
    return (
        <></>
    )
}

const HomePage = () => {
    return (
        <>
            <Introduction />
            <SearchBar />
            <SideMenu />
        </>
    )
}

export default SectionWrapper(HomePage, "home");