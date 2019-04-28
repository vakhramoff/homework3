# Немножко пояснений

Апишка в последней версии работает на сервере 89.208.199.118


# Подсосать готовенького юзера

```
/api/users/34de6cfb-548f-4860-9939-242017be1a3b
```


# Создать нового юзера через браузерную консольку

```
await fetch('/api/users/append',
{
	method: 'post',
	headers:
      	{
        	"Content-type": "application/json; charset=UTF-8"
      	},
	body: JSON.stringify
	(
		{
			nickname:"@test",
			email:"test@release.not",
			phone:"+7 777 7777777",
			position:"Ibragimov's Personal Coffeemaker (Released Version 2.0)"
		}
	)
	}
) .then(response => response.text())
```