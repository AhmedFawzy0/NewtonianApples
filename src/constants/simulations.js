import { cannonDemo, colDemo, dynamicsDemo } from "../assets"

const simulations = [
    {
        id: "kinSim",
        name: "Kinematics Simulation",
        description: "This is a simulation of a 2D kinematics cannonball problem. The cannon will automatically adjust depending on the values you type in for angle and velocity. Press space to shoot, right mouse to view trajectory, and press the clear balls button to clear the field of all balls. Two fields will automatically calculate horizontal rage and maximum vertical height",
        question: [
            `Why are units important?`,
            `Can you substitute in any unit for “units” in this simulation?`,
            `If your problem does not give you initial velocity or angle, would you still be able to use this simulator?`
        ],
        image: cannonDemo
    },
    {
        id: "dynamicsSym",
        name: "Incline Plane Simulation",
        description: "This a simulation of an incline plane box on a ramp problem. Input the values for the height and angle of the incline plane, the mass of the box, and the coefficient of friction between the box and the plane. Then press simulate. You’ll see the box go down from the ramp. Afterwards, press X when you’re done to be redirected back to the initial screen",
        question: [
            `You'll see at steeper angles the box tips when it hits the floor - while the problem may not account for this, do you think this is more "realistic"?`,
            `Why must the box start on the inline plane? Why could it not be dropped onto the incline plane?`
        ],
        image: dynamicsDemo
    },
    {
        id: "collisionSym",
        name: "Collision Simulation",
        description: "This is a simulation of an elastic collision problem. After inputting the masses and the initial velocities for the two boxes, press simulate and the collision simulation will start. There will be 3 fields that keep track of the velocity of the two boxes, as well as the number of collisions. You can press pause to stop the simulation at any time and then resume it. You can also reset the simulation back to initial starting conditions. If you want to start again with new initial conditions, press the red X on the right to be redirected back to the initial screen",
        question: [
            `Elastic means that an object to return to its normal shape after being stressed, why is this important in an elastic collision?`,
            `Look at how the velocities of the boxes change. What would be different if this were an inelastic collision?`
        ],
        image: colDemo
    }
]

export default simulations