import male from './icons/male.png';
import female from './icons/female.png';

import './Article.css';

function Article(props) {
    console.log(props.db);
    return (
        <div>
            {
                Object.keys(props.db["people"]).map(key => {
                    const item = props.db["people"][key];
                    let icon = item.pol === "male" ? male : female;

                    return (
                        <div className="card" key={key}>
                            <img src={item.photo} alt="" />
                            <div className="name">
                                {item.name + ' ' + item.surname}
                            </div>
                            <div className="pol">
                                <img src={icon} alt="" />
                            </div>
                            <div className="age">
                                {item.age} годиков
                            </div>
                        </div>
                    );
                })
            }
        </div>
    );
}

export default Article;
