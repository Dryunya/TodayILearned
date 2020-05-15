import React from 'react';
import { faPlus } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";

const Header = () => {
    return (
        <>
            <h1 className="title">Todostick</h1>
            <div className="field has-addons">
                <div className="control">
                    <input className="input is-medium" type="text" placeholder="Add new item"></input>
                </div>
                <div className="control">
                    <button className="button is-primary is-medium">
                        <span className="icon is-small">
                            <FontAwesomeIcon icon={faPlus} />
                        </span>
                        <span>Add</span>
                    </button>
                </div>
            </div>
        </>
    );
}

export default Header;