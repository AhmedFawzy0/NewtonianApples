import { Divider, Drawer, List, ListItem } from '@mui/material';
import { topics } from '../constants';
import { Link } from "react-router-dom";

const SideMenu = () => {
    return (
        <div>
            <Drawer variant='permanent' anchor='right' sx={{
                textAlign: 'center',
                justifyContent: "center",
                alignItems: "center",
                display: "flex",
                flexDirection: "column",
                width: "100%",
                '& .MuiDrawer-paper': {
                    justifyContent: "center",
                    minWidth: '130px', // Adjust the width as needed
                    margin: 'auto',
                }
            }} >
                <List sx={{
                    minHeight: "80px",
                    width: "inherit",
                    justifyContent: "center",
                    alignItems: "center"
                }}>
                    {topics.map((topic) => (
                        <div key={topic.id}>
                            <Link to={`/${topic.id}`} className='navLinks'>
                                <ListItem sx={{
                                    minHeight: "80px",
                                    paddingBottom: "10%",
                                    paddingTop: "10%",
                                    width: "inherit",
                                    justifyContent: "center",
                                    alignItems: "center",
                                    "&:hover": {
                                        backgroundColor: "#E0E0E0",
                                        borderRadius: "8px",
                                        cursor: 'pointer'
                                    },
                                }}>
                                    {topic.name}
                                </ListItem>
                                <Divider variant='middle' sx={{
                                    marginTop: "5px",
                                    marginBottom: "5px"
                                }} />
                            </Link>
                        </div>

                    ))}
                </List>
            </Drawer>
        </div>
    );
}

export default SideMenu