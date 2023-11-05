import { useState } from "react";
import SectionWrapper from "../hoc/SectionWrapper";
import "./Introduction.css"
import SideMenu from "./SideMenu";
import { apple } from "../assets";
import { simulations } from "../constants";
import Tilt from "react-parallax-tilt"

const SimulationCard = ({id, name, description, image}) => {
    return (
        <Tilt className="simulation-cards">
            <h3>
                {name}
            </h3>
            <p>
                description
            </p>
            <img src={image} alt={name} className="simulation-demo"/>
        </Tilt>
    )
}

const Introduction = () => {
    return (
        <div className="introduction">
            <div className="project-name-background">
                <h1 className="introduction-appName">
                    Newtonian Apples
                </h1>
                <img src={apple} alt="appleIcon" className="project-icon" />
            </div>
            <div className="introduction-content">
                <h2>
                    Simulation Topics
                </h2>

                <div className="introduction-topics">
                    {simulations.map((simulation, index) => (
                        <SimulationCard id={simulation.id} name={simulation.name}
                            description={simulation.description} key={simulation.id}
                            image={simulation.image}>
                            {simulation.name}
                        </SimulationCard>
                    ))}
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