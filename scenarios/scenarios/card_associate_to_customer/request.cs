﻿using Balanced;

Balanced.Balanced.configure("{{ api_key }}");

Card card = Card.Fetch("{{ uri }}");
card.AssociateToCustomer("{{payload.customer}}");