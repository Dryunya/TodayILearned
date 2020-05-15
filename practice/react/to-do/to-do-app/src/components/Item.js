import React from 'react';

const Item = () => {
    return (
        <div className="box">
            <div className="level">
                <div className="level-left">
                    <p className="subtitle">Hello world</p>
                </div>
                <div className="level-right">
                    <div class="buttons">
                        <button className="button is-success">Done</button>
                        <button className="button is-danger">Del</button>
                    </div>
                </div>
            </div>
        </div>
    );
}

export default Item;