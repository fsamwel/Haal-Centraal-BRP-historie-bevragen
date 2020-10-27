# coding: utf-8

"""
    BRP historie bevragen

    API voor het zoeken en raadplegen van historische verblijfplaatsen, partners, nationaliteiten en verblijfstitels uit de BRP (inclusief de RNI).  Zie de [Functionele documentatie](https://github.com/VNG-Realisatie/Haal-Centraal-BRP-historie-bevragen/tree/v1.0.0/features) voor nadere toelichting.   # noqa: E501

    The version of the OpenAPI document: 0.0.1 (develop)
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from openapi_client.configuration import Configuration


class PartnerhistorieAllOf(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'ontbinding_huwelijk_partnerschap': 'OntbindingHuwelijkPartnerschap'
    }

    attribute_map = {
        'ontbinding_huwelijk_partnerschap': 'ontbindingHuwelijkPartnerschap'
    }

    def __init__(self, ontbinding_huwelijk_partnerschap=None, local_vars_configuration=None):  # noqa: E501
        """PartnerhistorieAllOf - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._ontbinding_huwelijk_partnerschap = None
        self.discriminator = None

        if ontbinding_huwelijk_partnerschap is not None:
            self.ontbinding_huwelijk_partnerschap = ontbinding_huwelijk_partnerschap

    @property
    def ontbinding_huwelijk_partnerschap(self):
        """Gets the ontbinding_huwelijk_partnerschap of this PartnerhistorieAllOf.  # noqa: E501


        :return: The ontbinding_huwelijk_partnerschap of this PartnerhistorieAllOf.  # noqa: E501
        :rtype: OntbindingHuwelijkPartnerschap
        """
        return self._ontbinding_huwelijk_partnerschap

    @ontbinding_huwelijk_partnerschap.setter
    def ontbinding_huwelijk_partnerschap(self, ontbinding_huwelijk_partnerschap):
        """Sets the ontbinding_huwelijk_partnerschap of this PartnerhistorieAllOf.


        :param ontbinding_huwelijk_partnerschap: The ontbinding_huwelijk_partnerschap of this PartnerhistorieAllOf.  # noqa: E501
        :type: OntbindingHuwelijkPartnerschap
        """

        self._ontbinding_huwelijk_partnerschap = ontbinding_huwelijk_partnerschap

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, PartnerhistorieAllOf):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, PartnerhistorieAllOf):
            return True

        return self.to_dict() != other.to_dict()
